!function ($) {

    "use strict"; // jshint ;_;
    /* TAB CLASS DEFINITION
  * ==================== */
    var Tab = function (element) {
        this.element = $(element)
    }
    //鏁翠釜鎺т欢鍒嗕袱閮ㄥ垎,瑙﹀彂鍖轰笌闈㈡澘鍖�
    Tab.prototype = {

        constructor: Tab ,
        //杩欐槸鐢ㄤ簬鍒囨崲瑙﹀彂鍖轰笌鐩稿叧浜嬩欢,骞跺湪閲岄潰璋冪敤鍒囨崲闈㈡澘鐨刟ctivate
        show: function () {
            var $this = this.element
            , $ul = $this.closest('ul:not(.dropdown-menu)')//鎵惧埌瑙﹀彂鍖虹殑瀹瑰櫒
            , selector = $this.attr('data-target')//鍙栧緱瀵瑰簲鐨勯潰鏉跨殑CSS琛ㄨ揪寮�
            , previous
            , $target
            , e

            if (!selector) {
                selector = $this.attr('href')//娌℃湁鍒欎粠href寰楀埌
                selector = selector && selector.replace(/.*(?=#[^\s]*$)/, '') //strip for ie7
            }

            if ( $this.parent('li').hasClass('active') ) return

            previous = $ul.find('.active:last a')[0]//瀵瑰緱涔嬪墠琚縺娲荤殑閾炬帴

            e = $.Event('show', {
                relatedTarget: previous
            })

            $this.trigger(e)

            if (e.isDefaultPrevented()) return

            $target = $(selector)

            this.activate($this.parent('li'), $ul)
            this.activate($target, $target.parent(), function () {
                $this.trigger({
                    type: 'shown'
                    ,
                    relatedTarget: previous
                })
            })
        }  ,
        //杩欐柟闈笉搴旇鏀惧埌鍘熷瀷涓婏紝搴旇鍋氭垚绉佹湁鏂规硶
        activate: function ( element, container, callback) {
            var $deactivate = container.find('> .active')
            , transition = callback
            && $.support.transition
            && $deactivate.hasClass('fade')

            function next() {
                //璁╀箣鍓嶇殑澶勪簬婵€娲荤姸鎬佸浜庢縺娲荤姸鎬�
                $deactivate
                .removeClass('active')
                .find('> .dropdown-menu > .active')
                .removeClass('active')
                //璁╁綋鍓嶉潰鏉垮浜庢縺娲荤姸鎬�
                element.addClass('active')

                if (transition) {
                    element[0].offsetWidth // reflow for transition
                    element.addClass('in')
                } else {
                    element.removeClass('fade')
                }

                if ( element.parent('.dropdown-menu') ) {
                    element.closest('li.dropdown').addClass('active')
                }
                //鎵ц鍥炶皟锛岀洰鐨勬槸瑙﹀彂shown浜嬩欢
                callback && callback()
            }

            transition ?
            $deactivate.one($.support.transition.end, next) :
            next()
            //寮€濮嬭Е鍙慍SS3 transition鍥炶皟
            $deactivate.removeClass('in')
        }
    }


    /* TAB PLUGIN DEFINITION
  * ===================== */

    var old = $.fn.tab

    $.fn.tab = function ( option ) {
        return this.each(function () {
            var $this = $(this)
            , data = $this.data('tab')
            if (!data) $this.data('tab', (data = new Tab(this)))
            if (typeof option == 'string') data[option]()//show
        })
    }

    $.fn.tab.Constructor = Tab


    /* TAB NO CONFLICT
  * =============== */

    $.fn.tab.noConflict = function () {
        $.fn.tab = old
        return this
    }


    /* TAB DATA-API
  * ============ */
    //瑕佹眰瑙﹀彂鍖哄繀椤诲瓨鍦╗data-toggle="tab"]鎴朳data-toggle="pill"]灞炴€�
    $(document).on('click.tab.data-api', '[data-toggle="tab"], [data-toggle="pill"]', function (e) {
        e.preventDefault()
        $(this).tab('show')
    })

}(window.jQuery);