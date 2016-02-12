/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.GenericsTest', {
        genericListTest: function () {
            return new System.Collections.Generic.List$1(String)();
        },
        genericDictionaryTest: function () {
            return new System.Collections.Generic.Dictionary$2(String,System.Int32)();
        },
        genericListTest2: function () {
            return new System.Collections.Generic.List$1(Test.TestClass1)();
        },
        genericDictionaryTest2: function () {
            return new System.Collections.Generic.Dictionary$2(Test.TestClass1,Test.TestClass2)();
        }
    });
    
    Bridge.define('Test.TestClass1');
    
    Bridge.define('Test.TestClass2');
    
    Bridge.init();
})(this);
