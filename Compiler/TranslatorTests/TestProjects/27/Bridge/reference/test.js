/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.DebuggingTest', {
        Test1: function () {
            var page = new Test.Page(0);
            page.GetPage();
        }
    });//end of class Test.DebuggingTest
    
    Bridge.define('Test.Page', {
        _num: 0,
        constructor: function (num) {
            this._num = num;
        },
        GetPage: function () {
            return this._num;
        }
    });//end of class Test.Page
    
    Bridge.init();
})(this);
