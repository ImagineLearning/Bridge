/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.AnotherClass', {
        getterSetterTest: null,
        test3: function () {
            var i = this.getterSetterTest.MyInt;
            this.getterSetterTest.MyInt = 20;
        },
        test4: function () {
            var isTrue = this.getterSetterTest.MyBool;
        }
    });
    
    Bridge.define('Test.GetterSetterTest', {
        config: {
            properties: {
                MyInt: 0,
                MyBool: false
            }
        },
        test1: function () {
            var i = this.MyInt;
            this.MyInt = 20;
        },
        test2: function () {
            var isTrue = this.MyBool;
            this.MyBool = true;
        }
    });
    
    Bridge.init();
})(this);
