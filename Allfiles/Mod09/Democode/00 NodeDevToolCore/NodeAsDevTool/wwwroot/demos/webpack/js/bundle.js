/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, {
/******/ 				configurable: false,
/******/ 				enumerable: true,
/******/ 				get: getter
/******/ 			});
/******/ 		}
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = 0);
/******/ })
/************************************************************************/
/******/ ([
/* 0 */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\n\nvar _login = __webpack_require__(1);\n\nvar _utils = __webpack_require__(2);\n\ndebugger;\n(0, _login.login)('admin', 'pwd');\n\nvar u = new _utils.Utils();\nu.log(\"all loaded and executed!\");//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly8vLi9hcHAuanM/ZDhlZSJdLCJuYW1lcyI6WyJ1IiwibG9nIl0sIm1hcHBpbmdzIjoiOztBQUFBOztBQUNBOztBQUVBO0FBQ0Esa0JBQU0sT0FBTixFQUFlLEtBQWY7O0FBRUEsSUFBSUEsSUFBSSxrQkFBUjtBQUNBQSxFQUFFQyxHQUFGLENBQU0sMEJBQU4iLCJmaWxlIjoiMC5qcyIsInNvdXJjZXNDb250ZW50IjpbImltcG9ydCB7bG9naW59IGZyb20gXCIuL2xvZ2luLmpzXCJcclxuaW1wb3J0IHtVdGlsc30gZnJvbSBcIi4vdXRpbHMuanNcIlxyXG5cclxuZGVidWdnZXI7XHJcbmxvZ2luKCdhZG1pbicsICdwd2QnKTtcclxuXHJcbmxldCB1ID0gbmV3IFV0aWxzKCk7XHJcbnUubG9nKFwiYWxsIGxvYWRlZCBhbmQgZXhlY3V0ZWQhXCIpO1xuXG5cbi8vIFdFQlBBQ0sgRk9PVEVSIC8vXG4vLyAuL2FwcC5qcyJdLCJzb3VyY2VSb290IjoiIn0=\n//# sourceURL=webpack-internal:///0\n");

/***/ }),
/* 1 */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\n\nObject.defineProperty(exports, \"__esModule\", {\n    value: true\n});\n\nvar login = function login(usrname, password) {\n    if (usrname !== 'admin' || password !== 'pwd') {\n        console.log('incorrect login');\n    } else {\n        console.log('logged in using ' + usrname + ' and ' + password);\n    }\n};\n\nexports.login = login;//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly8vLi9sb2dpbi5qcz8xZGY5Il0sIm5hbWVzIjpbImxvZ2luIiwidXNybmFtZSIsInBhc3N3b3JkIiwiY29uc29sZSIsImxvZyJdLCJtYXBwaW5ncyI6Ijs7Ozs7O0FBQ0EsSUFBSUEsUUFBUSxTQUFTQSxLQUFULENBQWVDLE9BQWYsRUFBd0JDLFFBQXhCLEVBQWtDO0FBQzFDLFFBQUlELFlBQVksT0FBWixJQUF1QkMsYUFBYSxLQUF4QyxFQUErQztBQUMzQ0MsZ0JBQVFDLEdBQVIsQ0FBWSxpQkFBWjtBQUNILEtBRkQsTUFFTztBQUNIRCxnQkFBUUMsR0FBUixzQkFBK0JILE9BQS9CLGFBQThDQyxRQUE5QztBQUNIO0FBQ0osQ0FORDs7UUFRUUYsSyxHQUFBQSxLIiwiZmlsZSI6IjEuanMiLCJzb3VyY2VzQ29udGVudCI6WyJcclxubGV0IGxvZ2luID0gZnVuY3Rpb24gbG9naW4odXNybmFtZSwgcGFzc3dvcmQpIHtcclxuICAgIGlmICh1c3JuYW1lICE9PSAnYWRtaW4nIHx8IHBhc3N3b3JkICE9PSAncHdkJykge1xyXG4gICAgICAgIGNvbnNvbGUubG9nKCdpbmNvcnJlY3QgbG9naW4nKTtcclxuICAgIH0gZWxzZSB7XHJcbiAgICAgICAgY29uc29sZS5sb2coYGxvZ2dlZCBpbiB1c2luZyAke3Vzcm5hbWV9IGFuZCAke3Bhc3N3b3JkfWApO1xyXG4gICAgfVxyXG59XHJcblxyXG5leHBvcnQge2xvZ2luIH1cclxuXG5cblxuLy8gV0VCUEFDSyBGT09URVIgLy9cbi8vIC4vbG9naW4uanMiXSwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///1\n");

/***/ }),
/* 2 */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\n\nObject.defineProperty(exports, \"__esModule\", {\n    value: true\n});\n\nvar _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if (\"value\" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();\n\nfunction _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError(\"Cannot call a class as a function\"); } }\n\nvar Utils = exports.Utils = function () {\n    function Utils() {\n        _classCallCheck(this, Utils);\n    }\n\n    _createClass(Utils, [{\n        key: \"log\",\n        value: function log(msg) {\n            console.log(msg);\n        }\n    }]);\n\n    return Utils;\n}();//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly8vLi91dGlscy5qcz9lOGZiIl0sIm5hbWVzIjpbIlV0aWxzIiwibXNnIiwiY29uc29sZSIsImxvZyJdLCJtYXBwaW5ncyI6Ijs7Ozs7Ozs7OztJQUNhQSxLLFdBQUFBLEs7Ozs7Ozs7NEJBQ0pDLEcsRUFBSztBQUNOQyxvQkFBUUMsR0FBUixDQUFZRixHQUFaO0FBQ0giLCJmaWxlIjoiMi5qcyIsInNvdXJjZXNDb250ZW50IjpbIlxyXG5leHBvcnQgY2xhc3MgVXRpbHMge1xyXG4gICAgbG9nIChtc2cpIHtcclxuICAgICAgICBjb25zb2xlLmxvZyhtc2cpO1xyXG4gICAgfVxyXG59XG5cblxuLy8gV0VCUEFDSyBGT09URVIgLy9cbi8vIC4vdXRpbHMuanMiXSwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///2\n");

/***/ })
/******/ ]);