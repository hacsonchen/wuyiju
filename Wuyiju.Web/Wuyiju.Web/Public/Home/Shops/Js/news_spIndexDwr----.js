// Provide a default path to dwr.engine
if (dwr == null) var dwr = {};
if (dwr.engine == null) dwr.engine = {};
if (DWREngine == null) var DWREngine = dwr.engine;

dwr.engine._defaultPath = '/shopmm/dwr';

if (spIndexDwr == null) var spIndexDwr = {};
spIndexDwr._path = '/shopmm/dwr';
spIndexDwr.querySameShops = function(p0, p1, p2, callback) {
  dwr.engine._execute(spIndexDwr._path, 'spIndexDwr', 'querySameShops', p0, p1, p2, callback);
}
spIndexDwr.queryJingShops = function(p0, p1, p2, callback) {
  dwr.engine._execute(spIndexDwr._path, 'spIndexDwr', 'queryJingShops', p0, p1, p2, callback);
}
spIndexDwr.DayTopShops = function(callback) {
  dwr.engine._execute(spIndexDwr._path, 'spIndexDwr', 'DayTopShops', callback);
}
spIndexDwr.queryShops = function(p0, p1, p2, callback) {
  dwr.engine._execute(spIndexDwr._path, 'spIndexDwr', 'queryShops', p0, p1, p2, callback);
}
spIndexDwr.SetRegMsgNum = function(p0, callback) {
  dwr.engine._execute(spIndexDwr._path, 'spIndexDwr', 'SetRegMsgNum', p0, callback);
}
spIndexDwr.SendXuqiu = function(p0, p1, p2, p3, callback) {
  dwr.engine._execute(spIndexDwr._path, 'spIndexDwr', 'SendXuqiu', p0, p1, p2, p3, callback);
}