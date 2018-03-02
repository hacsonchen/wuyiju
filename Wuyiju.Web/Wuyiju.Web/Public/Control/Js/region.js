/* 多级选择相关函数，如地区选择，分类选择
 * multi-level selection
 */

/* 地区选择函数 */
function regionInit(divId)
{
    $("#" + divId + " > select").change(regionChange); // select的onchange事件
    $("#" + divId + " > input:button[class='edit_region']").click(regionEdit); // 编辑按钮的onclick事件
}

function regionChange()
{
    // 删除后面的select
    $(this).nextAll("select").remove();

    // 计算当前选中到id和拼起来的name
    var selects = $(this).siblings("select").andSelf();
    var id = 0;
    var names = new Array();
    for (i = 0; i < selects.length; i++)
    {
        sel = selects[i];
        if (sel.value > 0)
        {
            id = sel.value;
            name = sel.options[sel.selectedIndex].text;
            names.push(name);
        }
    }
    $(".mls_id").val(id);
    $(".mls_name").val(name);
    $(".mls_names").val(names.join("\t"));

    // ajax请求下级地区
    if (this.value > 0)
    {
		var _self = this;
        var url = '/mall/region/region.html';
        $.getJSON(url, {'pid':this.value}, function(data){
            if (data)
            {
                if (data.length > 0)
                {
                    $("<select><option>请选择</option></select>").change(regionChange).insertAfter(_self);
                    for (i = 0; i < data.length; i++)
                    {
                        $(_self).next("select").append("<option value='" + data[i].region_id + "'>" + data[i].region_name + "</option>");
                    }
                }
            }
            else
            {
                alert(data);
            }
        });
    }
}

function regionEdit()
{
    $(this).siblings("select").show();
    $(this).siblings("span").andSelf().hide();
}
