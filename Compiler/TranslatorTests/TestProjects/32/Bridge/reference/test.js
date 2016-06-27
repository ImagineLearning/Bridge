/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.ClassWithNullable', {
        _myNullableInt: null,
        MyNullableBool: null,
        Test1: function () {
            if (this.MyNullableBool === true) {
                this._myNullableInt = 100;
            }
    
            if (this._myNullableInt > 99) {
                this.MyNullableBool = false;
            }
    
            if (this._myNullableInt === 100) {
                this._myNullableInt = 101;
            }
        }
    });//end of class Test.ClassWithNullable
    
    Bridge.init();
})(this);
