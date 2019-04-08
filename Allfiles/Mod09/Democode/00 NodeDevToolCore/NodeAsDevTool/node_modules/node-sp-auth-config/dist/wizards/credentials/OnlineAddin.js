"use strict";
var __assign = (this && this.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
Object.defineProperty(exports, "__esModule", { value: true });
var inquirer = require("inquirer");
var utils_1 = require("../../utils");
var wizard = function (authContext, answersAll, _settings) {
    if (answersAll === void 0) { answersAll = {}; }
    if (_settings === void 0) { _settings = {}; }
    var onlineAddinCredentials = authContext.authOptions;
    var promptFor = [
        {
            name: 'clientId',
            message: 'clientId',
            type: 'input',
            default: onlineAddinCredentials.clientId,
            validate: function (answer) { return answer.length > 0; }
        }, {
            name: 'clientSecret',
            message: 'clientSecret',
            type: 'password',
            default: onlineAddinCredentials.clientSecret ? utils_1.defaultPasswordMask : null,
            validate: function (answer) { return answer.length > 0; }
        }
    ];
    return inquirer.prompt(promptFor).then(function (answers) {
        return __assign({}, answersAll, answers, { clientSecret: answers.clientSecret === utils_1.defaultPasswordMask
                ? onlineAddinCredentials.clientSecret
                : answers.clientSecret });
    });
};
exports.default = wizard;
//# sourceMappingURL=OnlineAddin.js.map