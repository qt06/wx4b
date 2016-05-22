if(!iamwx) {
var iamwx = true;
if(!!MutationObserver) {
alert('一切准备就绪，请您尽情享用吧。这是由晴天优化的微信网页版。');
var mcallback = function(records) {

records.map(function(record) {
var defaultTitle = '微信网页版（晴天优化）';
if(record.type == 'attributes' && record.target.nodeType == 1) {
var currentTitle = record.target.querySelector('.title_name');
if(currentTitle != null) {
currentTitle.setAttribute('accessKey','c');
window.external.Text = '正在与' + currentTitle.innerText + '对话';
}
var editArea = record.target.querySelector('.edit_area');
if(editArea != null) {
editArea.setAttribute('aria-label', '输入');
editArea.setAttribute('accessKey', 'z');
}

}
if(record.type == 'childList' && record.addedNodes.length > 0){
var newNodes = record.addedNodes;
for(i = 0, len = newNodes.length; i < len; i++) {
if(newNodes[i].nodeType == 1) {
var chat = newNodes[i].querySelector(".chat_item");
if(chat != null) {
chat.setAttribute('role', 'link');
chat.setAttribute('tabIndex', '0');
chat.setAttribute('accessKey', 'x');
chat.addEventListener('keyup', function(e) {if(e.keyCode == 13) { this.click();}}, null);
continue;
}
var msg = newNodes[i].querySelector('.message');
if(msg != null) {
msg.setAttribute('tabindex','-1');
msg.setAttribute('accesskey','c');
var voice = msg.querySelector('.voice');
if(voice != null) {
voice.setAttribute('role','button');
voice.setAttribute('tabIndex','0');
msg.addEventListener('keydown', function(e) {if(e.keyCode == 32 || e.keyCode == 13) { voice.click();}}, null);
}
var qqemojis = msg.querySelectorAll('img.qqemoji');
if(qqemojis.length > 0) {
var t = msg.innerText;
for(var i = 0, len = qqemojis.length; i < len; i++) {
if(qqemojis[i] != null) {
qqemojis[i].alt = qqemojis[i].getAttribute('text');
t += qqemojis[i].getAttribute('text');
}
}
msg.setAttribute('aria-label', t);
}
continue;
}
var contact = newNodes[i].querySelector(".contact_item");
if(contact != null) {
contact.setAttribute('role', 'link');
contact.setAttribute('tabIndex', '0');
contact.setAttribute('accessKey', 'x');
contact.addEventListener('keyup', function(e) {if(e.keyCode == 13) { this.click();}}, null);
window.external.Text = defaultTitle;
continue;
}
var contactTitle = newNodes[i].querySelector(".contact_title");
if(contactTitle != null) {
contactTitle.setAttribute('role', 'link');
contactTitle.setAttribute('tabIndex', '0');
contactTitle.setAttribute('accessKey', 'x');
contactTitle.addEventListener('keyup', function(e) {if(e.keyCode == 13) { this.click();}}, null);
window.external.Text = defaultTitle;
continue;
}
var readHd = newNodes[i].querySelectorAll(".read_item_hd, .read_item");
if(readHd.length > 0) {
for(var i = 0, len = readHd.length; i < len; i++) {
if(readHd != null) {
readHd[i].setAttribute('role', 'link');
readHd[i].setAttribute('tabIndex', '0');
readHd[i].setAttribute('accessKey', 'x');
readHd[i].addEventListener('keyup', function(e) {if(e.keyCode == 13) { this.click();}}, null);
}
}
window.external.Text = defaultTitle;
continue;
}
var read = newNodes[i].querySelector(".read_item");
if(read != null) {
read.setAttribute('role', 'link');
read.setAttribute('tabIndex', '0');
read.setAttribute('accessKey', 'x');
read.addEventListener('keyup', function(e) {if(e.keyCode == 13) { this.click();}}, null);
window.external.Text = defaultTitle;
continue;
}
var iframe = newNodes[i].querySelector(".iframe");
if(iframe != null) {
iframe.setAttribute('accessKey', 'c');
window.external.Text = defaultTitle;
continue;
}
var editArea = newNodes[i].querySelector(".edit_area");
if(editArea != null) {
editArea.setAttribute('accessKey', 'z');
continue;
}
var profile = newNodes[i].querySelector(".profile");
if(profile != null) {
profile.setAttribute('accessKey','c');
profile.setAttribute('tabIndex', '-1');
var btn = profile.querySelector('.action_area a');
if(btn != null) btn.setAttribute('accessKey', 'c');
window.external.Text = '用户资料详情';
continue;
}
var tabItems = newNodes[i].querySelectorAll(".tab_item a");
if(tabItems.length > 0) {
for(var i = 0, len = tabItems.length; i < len; i++) {
if(tabItems[i] != null) tabItems[i].setAttribute('accessKey','z');
}
continue;
}
}
}
}
});
};

var mo = new MutationObserver(mcallback);
var moption = {
'childList': true,
'attributes': true,
'subtree': true
};
mo.observe(document.body, moption);

var tabItems = document.querySelectorAll(".tab_item a");
if(tabItems.length > 0) {
for(var i = 0, len = tabItems.length; i < len; i++) {
if(tabItems[i] != null) tabItems[i].setAttribute('accessKey','z');
}
}


} else {
alert('很抱歉，您无法使用，这可能是由于您的系统太古老或者浏览器太古老了。');
}
}
