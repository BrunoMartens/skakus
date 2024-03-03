
let apiConfig = {
    "target": "http://localhost:5058/",
    "secure": false,
    "logLevel": "debug",
    "pathRewrite": { "^/api": "/" }
}

module.exports = {
    "/api/*": apiConfig
}