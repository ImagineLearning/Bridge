/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.EventTest', {
        config: {
            events: {
                Completed: null
            }
        },
        fireCompleted: function () {
            this.Completed(this, new Object());
        },
        addEventHandler: function () {
            this.addCompleted(this.onCompleted);
        },
        removeEventHandler: function () {
            this.removeCompleted(this.onCompleted);
        },
        addEventHandlerDelegate: function () {
            this.addCompleted(function () {
                throw new System.NotImplementedException();
            });
        },
        onCompleted: function (sender, eventArgs) {
            throw new System.NotImplementedException();
        }
    });
    
    Bridge.init();
})(this);
