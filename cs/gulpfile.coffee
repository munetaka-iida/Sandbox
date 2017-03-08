gulp = require 'gulp'
shell = require 'gulp-shell'

# Abstract

gulp.task 'watch', ->
    gulp.run ['watch:cs']

gulp.task 'build', ->
    gulp.run ['build:cs']

# CS

gulp.task 'watch:cs', ['build:cs'], ->
    gulp.watch "*.cs", ['build:cs']

gulp.task 'build:cs', ->
    gulp.src "*.cs"
        .pipe shell([
            'echo <%= file.path %>'
            'mcs <%= file.path %>'
            'mono <%= file.path.replace(/.cs$/, \'.exe\') %>'
            'echo'
        ])
