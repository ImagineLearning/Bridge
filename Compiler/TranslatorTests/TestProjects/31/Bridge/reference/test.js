/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.ClassWithProperties', {
        _publicInt: 0,
        _protectedInt: 0,
        _privateInt: 0,
        PublicInt: function () {
            return this._publicInt;
        },
        PublicInt: function (value) {
            this._publicInt = value;
        },
        ProtectedInt: function () {
            return this._protectedInt;
        },
        ProtectedInt: function (value) {
            this._protectedInt = value;
        },
        PrivateInt: function () {
            return this._privateInt;
        },
        PrivateInt: function (value) {
            this._privateInt = value;
        }
    });//end of class Test.ClassWithProperties
    
    Bridge.init();
})(this);
