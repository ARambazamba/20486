$(document).ready(function () {
    var data = [
      { y: '2006', a: 50, b: 90 },
      { y: '2007', a: 65, b: 75 },
      { y: '2008', a: 50, b: 50 },
      { y: '2009', a: 75, b: 60 },
      { y: '2010', a: 80, b: 65 },
      { y: '2011', a: 90, b: 70 },
      { y: '2012', a: 100, b: 75 },
      { y: '2013', a: 115, b: 75 },
      { y: '2014', a: 120, b: 85 },
      { y: '2015', a: 145, b: 85 },
      { y: '2016', a: 160, b: 95 }
    ],
    config = {
        data: data,
        xkey: 'y',
        ykeys: ['a', 'b'],
        labels: ['Total Income', 'Total Expenses'],
        fillOpacity: 0.6,
        hideHover: 'auto',
        behaveLikeLine: true,
        resize: true,
        pointFillColors: ['#ffffff'],
        pointStrokeColors: ['black'],
        lineColors: ['gray', 'red']
    };
    config.element = 'area-chart';
    Morris.Area(config);
});