/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.AnotherClass', {
        eventTest: null,
        addEventHandler: function () {
            this.eventTest.add_Completed(this.eventTestOnCompleted);
        },
        removeEventHandler: function () {
            this.eventTest.remove_Completed(this.eventTestOnCompleted);
        },
        addEventHandlerDelegate: function () {
            this.eventTest.add_Completed(function () {
                throw new System.NotImplementedException();
            });
        },
        eventTestOnCompleted: function (sender, eventArgs) {
            throw new System.NotImplementedException();
        }
    });
    
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
            this.add_Completed(this.onCompleted);
        },
        removeEventHandler: function () {
            this.remove_Completed(this.onCompleted);
        },
        addEventHandlerDelegate: function () {
            this.add_Completed(function () {
                throw new System.NotImplementedException();
            });
        },
        onCompleted: function (sender, eventArgs) {
            throw new System.NotImplementedException();
        }
    });
    
    Bridge.init();
})(this);
