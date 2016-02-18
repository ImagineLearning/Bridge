/* global Bridge */

(function (globals) {
    "use strict";

    define("MyModule", ["bridge"], function (_) {
        var exports = { };
        Bridge.define('TestProject2.TestClassB', {
            config: {
                properties: {
                    Value1: 0
                }
            }
        });//end of class TestProject2.TestClassB
        return exports;
    });
    
    
    
    Bridge.init();
})(this);
