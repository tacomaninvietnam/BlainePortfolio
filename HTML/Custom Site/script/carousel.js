$(function(){
	var $slider = $('.panel-inner');
	var liW = 101;
	var liFW = parseInt (liW * ($slider.find('li').length + 1));
	$slider.css('width', liFW + 'px');
	$('.button').click(function() {
	var leftX = (this.id == 'right') ?
		parseInt ($slider.css ('left').toString().replace('-','')) :
		parseInt ($slider.css ('left'));
	var leftY = (this.id == 'right') ? ((leftX + 404) == liFW) ? 0: -
		(leftX + liW) : (leftX < 0) ? -
		(parseInt(leftX.toString().replace('-', '')) - liW) : 0;
		rotate (leftY);
	});
	var rotate = function(leftY) {$slider.animate({left: leftY},500);}
});

