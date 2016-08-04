if (!iamwx) {
  var iamwx = true;
  if ( !! MutationObserver) {
    alert('一切准备就绪，请您尽情享用吧。这是由晴天优化的微信网页版。');
    var defaultTitle = '微信网页版（晴天优化）';
    var mcallback = function(records) {
      records.forEach(function(record) {
        if (record.type == 'attributes' && record.target.nodeType == 1) {
          var titleWrap = record.target.querySelector('.title_wrap');
          if (titleWrap != null) {
            titleWrap.setAttribute('tabIndex', '-1');
            titleWrap.setAttribute('accessKey', 't');
            var titleName = titleWrap.querySelector('.title_name');
            if (titleName != null) {
              titleName.setAttribute('accessKey', 'c');
              setWindowTitle(titleName.innerText);
            }
          }
          var editArea = record.target.querySelector('.edit_area');
          if (editArea != null) {
            editArea.setAttribute('aria-label', '输入');
            editArea.setAttribute('accessKey', 'z');
          }
        }

        if (record.type == 'childList' && record.addedNodes.length > 0) {
          var newNodes = record.addedNodes;
          for (var i = 0, len = newNodes.length; i < len; i++) {
            if (newNodes[i].nodeType == 1) {
              var chat = newNodes[i].querySelector(".chat_item");
              if (chat != null) {
                chat.setAttribute('role', 'link');
                chat.setAttribute('tabIndex', '0');
                chat.setAttribute('accessKey', 'x');
                chat.addEventListener('keydown',
                function(e) {
                  if (e.keyCode == 13) {
                    this.click();
                    setWindowTitle(this.innerText);
                  }
                },
                null);
                continue;
              }

              var msg = newNodes[i].querySelector('.message');
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
                continue;
              }

              var contact = newNodes[i].querySelectorAll(".contact_title, .contact_item");
              if (contact.length > 0) {
                for (var i = 0,
                len = contact.length; i < len; i++) {
                  if (contact[i] != null) {
                    contact[i].setAttribute('role', 'link');
                    contact[i].setAttribute('tabIndex', '0');
                    contact[i].setAttribute('accessKey', 'x');
                    contact[i].addEventListener('keyup',
                    function(e) {
                      if (e.keyCode == 13) {
                        this.click();
                        setWindowTitle(this.innerText);
                      }
                    },
                    null);
                  }
                }
                continue;
              }

              var read = newNodes[i].querySelectorAll(".read_item_hd, .read_item");
              if (read.length > 0) {
                for (var i = 0,
                len = read.length; i < len; i++) {
                  if (read[i] != null) {
                    read[i].setAttribute('role', 'link');
                    read[i].setAttribute('tabIndex', '0');
                    read[i].setAttribute('accessKey', 'x');
                    read[i].addEventListener('keydown',
                    function(e) {
                      if (e.keyCode == 13) {
                        this.click();
                        setWindowTitle(this.innerText);
                      }
                    },
                    null);
                  }
                }
                continue;
              }

              var iframe = newNodes[i].querySelector(".iframe");
              if (iframe != null) {
                iframe.setAttribute('accessKey', 'c');
                continue;
              }

              var profile = newNodes[i].querySelector(".profile");
              if (profile != null) {
                profile.setAttribute('accessKey', 'c');
                profile.setAttribute('tabIndex', '-1');
                var btn = profile.querySelector('.action_area a');
                if (btn != null) btn.setAttribute('accessKey', 'c');
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
    if (tabItems.length > 0) {
      for (var i = 0,
      len = tabItems.length; i < len; i++) {
        if (tabItems[i] != null) {
          tabItems[i].setAttribute('accessKey', 'z');
          tabItems[i].addEventListener('keydown',
          function(e) {

            if (e.keyCode == 13) {

              setWindowTitle(this.title + ' - ' + defaultTitle);
            }
          },
          null);
        }
      }
    }
    function setWindowTitle(title) {
      window.external.Text = title;
    }

  } else {
    alert('很抱歉，您无法使用，这可能是由于您的系统太古老或者浏览器太古老了。');
  }
}