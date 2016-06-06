/* global Bridge */

(function (globals) {
    "use strict";

    Bridge.define('Test.DDP', {
        inherits: [Test.IDynamicDataProvider],
        getParsedObjects: function () {
            return null;
        },
        setParsedObjects: function (value) {
        },
        LoadJson: function (json) {
        },
        LoadJsonFile: function (json) {
        }
    });//end of class Test.DDP
    
    Bridge.define('Test.ExternalConstructorTest2', {
        Test1: function () {
            var page = new Test.SoundCheckDataProvider("constructor$1", new Test.DDP());
            page.GetWordsForDataSet(21);
        }
    });//end of class Test.ExternalConstructorTest2
    
    Bridge.define('Test.SoundCheckData', {
        config: {
            properties: {
                NumberOfSounds: 0
            }
        }
    });//end of class Test.SoundCheckData
    
    Bridge.define('Test.SoundCheckDataProvider', {
        statics: {
            SoundCheckJsonPath: "DynamicData/SoundCheck.json"
        },
        _dynamicDataProvider: null,
        constructor$1: function (dynamicDataProvider) {
            this._dynamicDataProvider = dynamicDataProvider;
            if (this._dynamicDataProvider.ParsedObjects == null) {
                this._dynamicDataProvider.LoadJsonFile(SoundCheckDataProvider.statics.SoundCheckJsonPath);
            }
        },
        GetWordsForDataSet: function (dataSetNum) {
            if (dataSetNum === 21) {
                return [Bridge.merge(new Test.SoundCheckData(), {
                    NumberOfSounds: 5
                } ), Bridge.merge(new Test.SoundCheckData(), {
                    NumberOfSounds: 3
                } ), Bridge.merge(new Test.SoundCheckData(), {
                    NumberOfSounds: 3
                } ), Bridge.merge(new Test.SoundCheckData(), {
                    NumberOfSounds: 3
                } ), Bridge.merge(new Test.SoundCheckData(), {
                    NumberOfSounds: 4
                } )];
            }
    
    
            return null;
        }
    });//end of class Test.SoundCheckDataProvider
    
    Bridge.init();
})(this);
