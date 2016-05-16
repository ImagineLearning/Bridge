/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.Page', {
        inherits: [TestProject.Activity],
        _num: 0,
        constructor: function (num) {
            this._num = num;
        },
        CallMyParentsMethodWithDefaults: function () {
            this.MethodWithDefaults(1, 2, 7, 4, null);
        },
        CallMyParentsMethod: function () {
            this.MethodWithDefaults(0, 2, 3, 4, null);
        }
    });//end of class Test.Page
    
    Bridge.define('Test.SpecificActivity', {
        Test1: function () {
            var page = new Test.Page(0);
        }
    });//end of class Test.SpecificActivity
    
    Bridge.init();
})(this);
