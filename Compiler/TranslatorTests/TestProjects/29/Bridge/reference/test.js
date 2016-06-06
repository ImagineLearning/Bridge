/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.ExternalConstructorTest', {
        Test1: function () {
            var page = new Test.Page("constructor$1", 0);
            page.GetPage();
    
            var page2 = new Test.Page2("constructor$1", 0);
            page2.GetPage();
        }
    });//end of class Test.ExternalConstructorTest
    
    Bridge.define('Test.Page', {
        _num: 0,
        constructor: function () {
            this._num = 0;
        },
        constructor$1: function (num) {
            this._num = num;
        },
        GetPage: function () {
            return this._num;
        }
    });//end of class Test.Page
    
    Bridge.define('Test.Page2', {
        _num: 0,
        constructor$1: function (num) {
            this._num = num;
        },
        GetPage: function () {
            return this._num;
        }
    });//end of class Test.Page2
    
    Bridge.init();
})(this);
