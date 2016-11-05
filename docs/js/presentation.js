(function () {
  Reveal.initialize({
    dependencies: [{
      src: 'js/highlight.js',
      async: true,
      callback: function() { hljs.initHighlightingOnLoad(); }
    }]
  });
}());
