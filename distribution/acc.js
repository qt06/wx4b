if (!iamwx) {
	var iamwx = true;
	if ( !! MutationObserver) {
		playSound('welcome.mp3');
		alert('一切准备就绪，请您尽情享用吧。这是由晴天优化的微信网页版。');
		var defaultTitle = '微信网页版（晴天优化）';
		var lastWindowTitle = '';
		navProcess();
		childListProcess(document);
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

	var titleWrap = d.querySelector('.title_wrap');
	if (titleWrap != null) {
		titleWrap.setAttribute('tabIndex', '-1');
		titleWrap.setAttribute('accessKey', 't');
		//playSound('welcome.mp3');
		//setWindowTitle('wrap' + titleWrap.innerText);
	}

	var titleName = d.querySelector('.title_name');
	if (titleName != null) {
		titleName.setAttribute('accessKey', 'c');
		//playSound('welcome1.mp3');
		//setWindowTitle(titleName.innerText);
	}

	var editArea = d.querySelector('.edit_area');
	if (editArea != null) {
		editArea.setAttribute('aria-label', '输入');
		editArea.setAttribute('accessKey', 'z');
	}
}

function childListProcess(d) {
	aae(d, ".chat_item, .contact_title, .contact_item, .read_item_hd, .read_item, .member, .opt", {
		"role": "link",
		"tabIndex": "0",
		"accessKey": "x"
	},
	{
		"keydown": function(e) {
			if (e.keyCode == 13) {
				this.click();
			}
		}
	});

	var msg = d.querySelector('.message');
	if (msg != null) {
		msg.setAttribute('tabindex', '-1');
		msg.setAttribute('accesskey', 'c');
		var voice = msg.querySelector('.voice');
		if (voice != null) {
			voice.setAttribute('role', 'button');
			voice.setAttribute('tabIndex', '0');
			msg.addEventListener('keydown',
			function(e) {
				if (e.keyCode == 32 || e.keyCode == 13) {
					voice.click();
				}
			},
			null);
		}
		var qqemojis = msg.querySelectorAll('img.qqemoji');
		if (qqemojis.length > 0) {
			var t = msg.innerText;
			for (var i = 0,
			len = qqemojis.length; i < len; i++) {
				if (qqemojis[i] != null) {
					qqemojis[i].alt = qqemojis[i].getAttribute('text');
					t += qqemojis[i].getAttribute('text');
				}
			}
			msg.setAttribute('aria-label', t);
		}
	}

	addEvent(d, '.member', 'keydown',
	function(e) {
		if (e.keyCode == 13) {
			var img = this.querySelector('img');
			if (img != null) {

				img.click();
			}
		}
	});

	addEvent(d, '.contact_title, .contact_item', 'keydown',
	function(e) {
		if (e.keyCode == 13) {
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

	addEvent(d, '.read_item_hd, .read_item', 'keydown',
	function(e) {
		if (e.keyCode == 13) {
			this.click();
			setWindowTitle(this.innerText);
		}
	});

	aae(d, ".iframe", {
		"accessKey": "c"
	});

	var profile = d.querySelector(".profile");
	if (profile != null) {
		profile.setAttribute('accessKey', 'c');
		profile.setAttribute('tabIndex', '-1');
		var btn = profile.querySelector('.action_area a');
		if (btn != null) btn.setAttribute('accessKey', 'c');
	}
}

function navProcess() {
	aae(document, ".tab_item a", {
		"accessKey": "z"
	},
	{
		'keydown': function(e) {
			if (e.keyCode == 13) {
				setWindowTitle(this.title + ' - ' + defaultTitle);
			}
		}
	});
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

function aae(d, s, a, e) {
	addAttributeAndEvent(d, s, a, e);
}
function addAttributeAndEvent(d, s, attr, evt) {
	var hasAttr = typeof attr === 'object';
	var hasEvent = typeof evt === 'object';
	var els = d.querySelectorAll(s);
	if (els.length > 0) {
		for (var i = 0,
		len = els.length; i < len; i++) {
			if (els[i] != null) {
				if (hasAttr) {
					for (var k in attr) {
						els[i].setAttribute(k, attr[k]);
					}
				}
				if (hasEvent) {
					for (var t in evt) {
						els[i].addEventListener(t, evt[t], null);
					}
				}
			}
		}
	}
}

function addEvent(d, s, type, func) {
	var els = d.querySelectorAll(s);
	if (els.length > 0) {
		for (var i = 0,
		len = els.length; i < len; i++) {
			if (els[i] != null) {
				els[i].addEventListener(type, func, null);
			}
		}
	}
}