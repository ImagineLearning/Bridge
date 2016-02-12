/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.GenericsTest', {
        genericListTest: function () {
            return new (System.Collections.Generic.List(String))();
        },
        genericDictionaryTest: function () {
            return new (System.Collections.Generic.Dictionary(String,System.Int32))();
        },
        genericListTest2: function () {
            return new (System.Collections.Generic.List(Test.TestClass1))();
        },
        genericDictionaryTest2: function () {
            return new (System.Collections.Generic.Dictionary(Test.TestClass1,Test.TestClass2))();
        }
    });
    
    Bridge.define('Test.TestClass1');
    
    Bridge.define('Test.TestClass2');
    
    Bridge.init();
})(this);
