(function () {
  Reveal.initialize({
    dependencies: [{
      src: 'js/highlight.js',
      async: true,
      callback: function() { hljs.initHighlightingOnLoad(); }
    }],
    width: 1280,
    height: 720,
    history: true
  });
}());
