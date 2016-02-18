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
        }
    });//end of class Test.IndexerGetSetTests
    
    Bridge.init();
})(this);
