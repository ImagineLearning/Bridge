/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.AnotherClass');
    
    Bridge.define('Test.NullCheckTest', {
        myNullClass: null,
        checkForNullTest: function () {
            if (this.myNullClass != null) {
                throw new System.NotImplementedException();
            }
    
            if (this.myNullClass == null) {
                throw new System.NotImplementedException();
            }
        }
    });
    
    Bridge.init();
})(this);
