'use strict';

/* Filters */
angular.module('SwissCreateFilters', []).filter('checkmark', function () {
    return function (input) {
        return input ? '\u2713' : '\u2718';
    };
});