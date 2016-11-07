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
  Reveal.addEventListener('fragmentshown', function (event) {
    var current = document.querySelector('.whats-happening.current');
    var assocId = event.fragment.getAttribute('data-fragment-index');
    var node = document.getElementById('step-' + assocId);
    if (current) {
      current.classList.remove('current');
    }
    if (node) {
      node.classList.add('current');
      node.scrollIntoView();
    }
  });
}());
