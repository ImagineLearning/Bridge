/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.IndexerGetSetTests', {
        Test1: function () {
            var dictionary = new (System.Collections.Generic.Dictionary(System.String,System.Object))();
            dictionary.Add("key", 1);
            dictionary.Add("key2", 2);
    
            var val1 = dictionary["key"];
            var val2 = dictionary["key2"];
    
            dictionary["key2"] = 22;
        },
        Test2: function () {
            var list = new (System.Collections.Generic.List(System.String))();
            list.Add("string1");
            list.Add("string2");
    
            var val1 = list[0];
            var val2 = list[1];
    
            list[1] = "string3";
        }
    });//end of class Test.IndexerGetSetTests
    
    Bridge.init();
})(this);
