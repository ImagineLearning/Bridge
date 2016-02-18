/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.GenericsTest', {
        GenericListTest: function () {
            return new (System.Collections.Generic.List(System.String))();
        },
        GenericDictionaryTest: function () {
            return new (System.Collections.Generic.Dictionary(System.String,System.Int32))();
        },
        GenericListTest2: function () {
            return new (System.Collections.Generic.List(Test.TestClass1))();
        },
        GenericDictionaryTest2: function () {
            return new (System.Collections.Generic.Dictionary(Test.TestClass1,Test.TestClass2))();
        }
    });//end of class Test.GenericsTest
    
    Bridge.define('Test.TestClass1');//end of class Test.TestClass1
    
    Bridge.define('Test.TestClass2');//end of class Test.TestClass2
    
    Bridge.init();
})(this);
