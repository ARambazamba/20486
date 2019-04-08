var gulp = require("gulp");
var sass = require("gulp-sass");
var sourcemaps = require("gulp-sourcemaps");
var concat = require("gulp-concat");
var babel = require("gulp-babel");
var sourcemaps = require("gulp-sourcemaps");
var spsave = require("gulp-spsave");

var paths = {
  scriptSource: "./src/scripts/*.js",
  scss: "./src/sass/**/*.scss",
  dist: "./dist"
};

// Babel

gulp.task("babel:ToES5", () => {
  return gulp
    .src([paths.scriptSource + "es6*.js"])
    .pipe(sourcemaps.init())
    .pipe(babel({ presets: ["es2015"] }))
    .pipe(concat("es5bundle.js"))
    .pipe(sourcemaps.write("."))
    .pipe(gulp.dest(paths.dist));
});

// Compile sass

gulp.task("compile:sass", function() {
  return gulp
    .src(paths.scss)
    .pipe(sass())
    .pipe(gulp.dest(paths.dist));
});

// Watch sass

gulp.task("watch:sass", function() {
  gulp.watch(paths.scss, ["compile:sass"]);
});

// Upload to Files to SharePoint - local SharePoint @ http://sp2019 installed

var spsaveCoreOption = {
  siteUrl: "http://sp2019",
  folder: "Shared%20Documents",
  checkin: true,
  checkinType: 1,
  flatten: false,
  notification: true
};

var spsaveCredential = {
  username: "spdom\\administrator",
  password: "Pa$$w0rd"
};

gulp.task("upload", function() {
  return gulp
    .src("./dist/**/*")
    .pipe(spsave(spsaveCoreOption, spsaveCredential));
});
