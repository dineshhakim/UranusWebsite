/*
Copyright (c) 2003-2012, CKSource - Frederico Knabben. All rights reserved.
For licensing, see LICENSE.html or http://ckeditor.com/license
*/

CKEDITOR.editorConfig = function (config) {
    
    config.toolbar =
    [
      [
        'SourceBold',
        'Italic',
        'Underline',
        'Strike',
        '-',
        'Subscript',
        'SuperscriptNumberedList',
        'BulletedList',
        '-',
        'Outdent',
        'Indent/Styles',
        'Format',
        'Font',
        'FontSize'
      ]
    ];
    CKEDITOR.config.extraAllowedContent = 'p,span,h1,h2,h3(class1,class2),img,strong,em(class3)'
};