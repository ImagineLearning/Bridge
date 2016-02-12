/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.GenericsTest', {
        GenericListTest: function () {
            return new (System.Collections.Generic.List$1(String))();
        },
        GenericDictionaryTest: function () {
            return new (System.Collections.Generic.Dictionary$2(String,System.Int32))();
        },
        GenericListTest2: function () {
            return new (System.Collections.Generic.List$1(Test.TestClass1))();
        },
        GenericDictionaryTest2: function () {
            return new (System.Collections.Generic.Dictionary$2(Test.TestClass1,Test.TestClass2))();
        }
    });
    
    Bridge.define('Test.TestClass1');
    
    Bridge.define('Test.TestClass2');
    
    Bridge.init();
})(this);
