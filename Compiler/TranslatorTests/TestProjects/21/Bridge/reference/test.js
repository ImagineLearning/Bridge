/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.MyCoolActivity', {
        inherits: [Test.Activity],
        _myLocalProp: 0,
        _currentIcon: null,
        _num: 0,
        config: {
            properties: {
                AnotherProperty: false
            }
        },
        MyLocalProperty: function () {
            return this._myLocalProp;
        },
        MyLocalProperty: function (value) {
            this._myLocalProp = value;
        },
        CurrentIcon: function () {
            return this._currentIcon;
        },
        CurrentIcon: function (value) {
            this._currentIcon = value;
        },
        Num: function (value) {
            this._num = value;
        },
        test5: function () {
            var interaction = this.StateManager.Interaction;
            interaction = this.StateManager.Interaction;
        },
        test6: function () {
            var local = this.MyLocalProperty();
            var l = this._myLocalProp;
        },
        test7: function () {
            var anotherProperty = this.AnotherProperty;
        },
        test8: function () {
            this.StateManager.SomethingToSet = true;
            this.MyLocalProperty(5);
            this.AnotherProperty = true;
        },
        test12: function () {
            this._currentIcon.Anim1.Visible(true);
            this.CurrentIcon().Anim1.Visible(false);
        },
        test13: function () {
            this.Num(100);
    
            this.CurrentIcon().add_OnShow(this.currentIconOnOnShow);
        },
        currentIconOnOnShow: function (sender, eventArgs) {
            throw new System.NotImplementedException();
        }
    });//end of class Test.MyCoolActivity
    
    Bridge.define('Test.AnotherClass', {
        getterSetterTest: null,
        test3: function () {
            var i = this.getterSetterTest.MyInt;
            this.getterSetterTest.MyInt = 20;
    
            var myLocalProperty = this.getterSetterTest.MyLocalProperty();
            this.getterSetterTest.MyLocalProperty(5);
        },
        test4: function () {
            var isTrue = this.getterSetterTest.MyBool;
        }
    });//end of class Test.AnotherClass
    
    Bridge.define('Test.GetterSetterTest', {
        _myLocalProp: 0,
        config: {
            properties: {
                MyInt: 0,
                MyBool: false
            }
        },
        MyLocalProperty: function () {
            return this._myLocalProp;
        },
        MyLocalProperty: function (value) {
            this._myLocalProp = value;
        },
        test1: function () {
            var i = this.MyInt;
            this.MyInt = 20;
    
            var myLocalProperty = this.MyLocalProperty();
            this.MyLocalProperty(5);
        },
        test2: function () {
            var isTrue = this.MyBool;
            this.MyBool = true;
        }
    });//end of class Test.GetterSetterTest
    
    Bridge.define('Test.MyCoolActivity.AnimationWithSound', {
        config: {
            properties: {
                Animation: null
            }
        },
        Visible: function (value) {
            this.Animation.Visible = value;
        }
    });//end of class Test.MyCoolActivity.AnimationWithSound
    
    Bridge.define('Test.MyCoolActivity.Icon', {
        config: {
            events: {
                OnShow: null
            },
            properties: {
                Anim1: null
            }
        }
    });//end of class Test.MyCoolActivity.Icon
    
    Bridge.define('Test.Test_MyCoolActivity', {
        inherits: [Test.MyCoolActivity],
        test9: function () {
            var local = this.MyLocalProperty();
            var interaction = this.StateManager.Interaction;
        },
        test10: function () {
            var anotherProperty = this.AnotherProperty;
        },
        test11: function () {
            this.StateManager.SomethingToSet = true;
            this.MyLocalProperty(5);
            this.AnotherProperty = true;
        }
    });//end of class Test.Test_MyCoolActivity
    
    Bridge.init();
})(this);
