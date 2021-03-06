﻿var pug = require('pug');

module.exports = function (callback, viewPath, model) {
    // Invoke some external transpiler (e.g., an NPM module) then:
    // add error handling
	var pugCompiledFunction = pug.compileFile(viewPath);
	callback(null, pugCompiledFunction(model));	
};