﻿/* global Bridge */

(function (globals) {
    "use strict";

    /** @namespace TestProject2 */
    
    /**
     * @class TestProject2.TestClassB
     */
    Bridge.define('TestProject2.TestClassB', {
        config: {
            properties: {
                /**
                 * @instance
                 * @public
                 * @this TestProject2.TestClassB
                 * @memberof TestProject2.TestClassB
                 * @function Value1
                 * @return  {number}
                 */
                /**
                 * @instance
                 * @public
                 * @this TestProject2.TestClassB
                 * @memberof TestProject2.TestClassB
                 * @function Value1
                 * @param   {number}    value
                 * @return  {void}
                 */
                Value1: 0
            }
        }
    });//end of class TestProject2.TestClassB
    
    Bridge.init();
})(this);
