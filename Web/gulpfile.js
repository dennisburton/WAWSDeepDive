var gulp = require('gulp');
var htmlmin = require('gulp-htmlmin');

gulp.task('minify',function(){
    gulp.src('./app/pages/*.html')
        .pipe(htmlmin({collapseWhitespace:true}))
        .pipe(gulp.dest('./dist'))
});
