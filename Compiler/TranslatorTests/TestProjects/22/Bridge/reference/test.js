/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.ToStringTest', {
        Test1: function () {
            var i = 500;
    
            var str = i.toString();
    
            var length = str.Length;
    
            var eye = System.Convert.ToInt32(str);
    
            var equal = i === eye;
    
            var list = Bridge.merge(new (System.Collections.Generic.List(System.Int32))(), [
                [1],
                [2],
                [3],
                [4],
                [5],
                [6],
                [7],
                [8],
                [9],
                [10]
            ] );
    
            var greaterThan6 = list.Select(function (x) {
                return x > 5;
            }).ToList();
    
            var numGreaterThan6 = greaterThan6.Count;
        }
    });//end of class Test.ToStringTest
    
    Bridge.init();
})(this);
