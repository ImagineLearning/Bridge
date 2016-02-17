/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.StateConstantsTest', {
        statics: {
            StateOne: 1,
            staticInt: 2
        },
        accessConstantTest: function () {
            var value = StateConstantsTest.statics.StateOne;
            var value2 = StateConstantsTest.statics.staticInt;
        }
    });
    
    Bridge.init();
})(this);
