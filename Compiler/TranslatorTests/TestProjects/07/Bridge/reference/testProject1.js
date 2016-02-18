/* global Bridge */

(function (globals) {
    "use strict";

    define("MyModule", ["bridge"], function (_) {
        var exports = { };
        Bridge.define('TestProject1.TestClassA', {
            config: {
                properties: {
                    Value1: 0
                }
            }
        });//end of class TestProject1.TestClassA
        return exports;
    });
    
    
    
    Bridge.init();
})(this);
