if (!iamwx) {
	var iamwx = true;
	if ( !! MutationObserver) {
		playSound('welcome.mp3');
		//alert('一切准备就绪，请您尽情享用吧。这是由晴天优化的微信网页版。');
		var defaultTitle = '微信网页版（晴天优化）';
		var lastWindowTitle = '';

		navProcess();
		childListProcess(document);
eventhandlers();
		amo(attributeProcess, childListProcess);
	} else {
		alert('很抱歉，您无法使用，这可能是由于您的系统太古老或者浏览器太古老了。');
	}
}

function attributeProcess(d) {
	if (d.className.indexOf('title_name') === 0) {
		var title = d.innerText.trim();
		if (title != lastWindowTitle) {
			lastWindowTitle = title;
			playSound('welcome1.mp3');
			setWindowTitle(title);
		}
	}
$('.title_wrap', d).attr({
"tabindex": "-1",
"accesskey": "t"
});

$('.title_name', d).attr({"accesskey": "c"});

$('.edit_area', d).attr({"aria-label": "输入",
"accesskey":"z"
});
}
function eventhandlers() {
	$(document.body).on('keydown', function(e) {
		if(e.which == 38 || e.which ==40) {
			e.stopPropagation();
		}
	});
$(document).on("keydown", ".chat_item .info, .contact_title, .contact_item, .read_item_hd, .read_item, .member, .opt", function(e) {
			if (e.which == 13) {
				this.click();
			}
		}
	);
$(document).on('keydown', '.member',
function(e) {
		if (e.which == 13) {
$(this).find('img').click();
		}
});

$(document).on('keydown','.contact_title, .contact_item', function(e) {
		if (e.which == 13) {
			var opt = this.querySelector('.opt');
			if (opt != null) {
				//opt.setAttribute('role', 'checkbox');
				opt.click();
			} else {
				this.click();
				setWindowTitle(this.innerText);
			}
		}
});

$(document).on('keydown', '.read_item_hd, .read_item', function(e) {
		if (e.which == 13) {
			this.click();
			setWindowTitle(this.innerText);
		}
});
$(document).on('keydown', '.message', function(e) {
if(e.which == 13 || e.which == 32) {
$(this).find('.voice').click();
}
});
}

function childListProcess(d) {
	$(".chat_item .info, .contact_title, .contact_item, .read_item_hd, .read_item, .member, .opt", d).attr({
		"role": "link",
		"tabIndex": "0",
		"accessKey": "x"
	});
$('.profile', d).attr({
"tabindex": "-1",
"accesskey": "c"
});
$('.message', d).attr({
"tabindex": "-1",
"accesskey": "c",
"aria-label": function() {
		//playSound('msg.mp3');
var imgText = $(this).find('img.qqemoji, img.emoji').attr('text') || '';
return this.innerText + imgText;
}
}).find('.voice').attr({
"tabindex": "0",
"role": "button"
});
$('img.qqemoji, img.emoji', d).attr('alt', function() { return $(this).attr('text'); });
	$(".iframe, .action_area a", d).attr({
		"accessKey": "c"
	});
}

function navProcess() {
$(".tab_item a").attr({
		"accessKey": "z"
	});
$(document).on('keydown', ".tab_item a", function(e) {
			if (e.which == 13) {
				setWindowTitle(this.title + ' - ' + defaultTitle);
			}
		}
);
}

function amo(attributeProcess, chileListProcess) {
	var mcallback = function(records) {
		records.forEach(function(record) {
			//if (record.type == 'attributes') { 
			if (record.target.nodeType == 1) {
				attributeProcess(record.target);
				//end of the attributes
			}
			if (record.type == 'childList' && record.addedNodes.length > 0) {
				var newNodes = record.addedNodes;
				for (var i = 0,
				len = newNodes.length; i < len; i++) {
					if (newNodes[i].nodeType == 1) {
						childListProcess(newNodes[i]);
						//end of new nodes
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
}

function setWindowTitle(title) {
	window.external.Text = title;
}

function playSound(file) {
	//window.external.sound(file);
	var bgs = null;
	bgs = document.querySelector("bgsound");
	if (bgs == null) {
		bgs = document.createElement("bgsound");
		bgs.src = "";
		document.getElementsByTagName("body")[0].insertBefore(bgs);
	}
	if (bgs !== null) {
		bgs.src = "http://www.qt.hk/sound/" + file;
	}
}
