
jQuery(function(){jQuery("#gameCategoryListPy li a").mouseover(function(){type=jQuery(this).html();if(type=="\u53f0\u670d\u6e38\u620f"||type=="\u7f51\u9875\u6e38\u620f")type="WEBG";jQuery("#gameCategoryListPy li").removeClass();jQuery(this).parent().addClass("currert");jQuery("#py_index").addClass("first");jQuery("#gameCategoryListPyFrame").show();html="";if(type=="O"||type=="U")html='<li style="width:200px; font-size:14px;">\u8be5\u5b57\u6bcd\u4e0b\u6682\u65e0\u6e38\u620f</li>';else for(key in gamelist)if(gamelist[key].name.toUpperCase()==
type)for(key1 in gamelist[key].list){if(gamelist[key].list[key1].hot==1)tmpclass='class="hotgame"';else tmpclass="";html+="<li "+tmpclass+"><a onclick=\"__utmTrackEvent('\u9996\u9875\u70b9\u51fb','\u9009\u62e9\u6e38\u620f-\u62fc\u97f3\u7d22\u5f15','"+gamelist[key].list[key1].name+'\');" href="'+gamelist[key].list[key1].gameid+'.shtml" title="'+gamelist[key].list[key1].name+'">'+gamelist[key].list[key1].name+"</a></li>"}if(type!="WEBG")jQuery("#gameCategoryListPy li:last").addClass("last");
if(type!="A")jQuery("#py_a").parent().addClass("sec");jQuery("#gameCategoryListPyFrame").html(html)});jQuery(".home_gamelist .title").mouseover(function(){_removeGameListDiv()});jQuery(".appraise").mouseover(function(){_removeGameListDiv()});jQuery("#gameCategoryListPyFrame").bind("mouseleave",function(){_removeGameListDiv()});function _removeGameListDiv(){if(jQuery("#gameCategoryListPyFrame").css("display")=="block"){jQuery("#gameCategoryListPyFrame").hide();jQuery("#gameCategoryListPy li").removeClass();
jQuery("#py_index").addClass("first");jQuery("#py_a").parent().addClass("sec");jQuery("#gameCategoryListPy li:last").addClass("last")}}jQuery("#gameCategoryListPy li:last").addClass("last");jQuery("#diankaNavTab li").mouseover(function(){jQuery("#diankaNavTab li").removeClass("currert");jQuery(this).addClass("currert");jQuery(".cardlist").hide();jQuery("#diankaNavFrame"+this.id.substr(4)).show()});jQuery("#hotinfoTabNav li").mouseover(function(){jQuery("#hotinfoTabNav li").removeClass("currert");
jQuery(this).addClass("currert");jQuery(".hotinfo_frame").hide();jQuery("#hotinfo"+this.id.substr(4)).show()})});function Each(list,fun){for(var i=0,len=list.length;i<len;i++)fun(list[i],i)}var objs=document.getElementById("numID").getElementsByTagName("li");var tv=new TransformView("carousellist","playcarouse",360,objs.length,{onStart:function(){Each(objs,function(o,i){o.className=tv.Index==i?"currert":""})},Pause:6E3});tv.Start();
Each(objs,function(o,i){o.onmouseover=function(){o.className="currert";tv.Auto=false;tv.Index=i;tv.Start()};o.onmouseout=function(){o.className="";tv.Auto=true;tv.Start()}});if(document.getElementById("grouplist"))ued_marquee("grouplist",22,50,5E3);if(document.getElementById("marqueebox1"))ued_marquee("marqueebox1",21,50,3E3);if(document.getElementById("marqueebox2"))ued_marquee("marqueebox2",21,50,3E3);
function ued_marquee(id,lineheight,speed,delay){var t;var p=false;var o=document.getElementById(id);o.innerHTML+=o.innerHTML;o.onmouseover=function(){p=true};o.onmouseout=function(){p=false};o.scrollTop=0;function start(){t=setInterval(scrolling,speed);if(!p)o.scrollTop+=2}function scrolling(){if(o.scrollTop%lineheight!=0){o.scrollTop+=2;if(o.scrollTop>=o.scrollHeight/2)o.scrollTop=0}else{clearInterval(t);setTimeout(start,delay)}}setTimeout(start,delay)};