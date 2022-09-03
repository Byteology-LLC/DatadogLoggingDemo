$(function () {
    abp.log.debug('Index.js initialized!');

});

$(".simulate").click(function () {
    var logger = datadogLoggingDemo.loggingTest;
    var notification = "log";

    switch ($(this).data("level")) {
        case "error":
            logger.createErrorLog();            
            break;
        case "warning":
            logger.createWarningLog();
            break;
        case "critical":
            logger.createCriticalLog();
            break;
        case "trace":
            logger.createTraceLog();
            break;
        case "info":
            logger.createInfoLog();
            break;
        default:
            logger.simulateException();
            notification = "exception";
            break;
    }
    abp.notify.success("Successfully tested " + notification);

});
