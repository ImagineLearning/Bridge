/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.RemoveAsTest', {
        Test1: function () {
            var myString = "a string";
            var castedString = myString;
        }
    });//end of class Test.RemoveAsTest
    
    Bridge.init();
})(this);
