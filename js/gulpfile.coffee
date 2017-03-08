gulp = require 'gulp'
shell = require 'gulp-shell'

# Abstract

gulp.task 'watch', ->
    gulp.run ['watch:js']

gulp.task 'build', ->
    gulp.run ['build:js']

# ES6

gulp.task 'watch:js', ['build:js'], ->
    gulp.watch "*.js", ['build:js']

gulp.task 'build:js', ->
    gulp.src "*.js"
        .pipe shell([
            'echo <%= file.path %>'
            'node <%= file.path %>'
            'echo'
        ])
