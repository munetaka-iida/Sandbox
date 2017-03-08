gulp = require 'gulp'
shell = require 'gulp-shell'

# Abstract

gulp.task 'watch', ->
    gulp.run ['watch:rb']

gulp.task 'build', ->
    gulp.run ['build:rb']

# Ruby

gulp.task 'watch:rb', ['build:rb'], ->
    gulp.watch "*.rb", ['build:rb']

gulp.task 'build:rb', ->
    gulp.src "*.rb"
        .pipe shell([
            'echo <%= file.path %>'
            'ruby <%= file.path %>'
            'echo'
        ])
