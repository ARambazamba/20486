const path = require('path');

module.exports = {
    context: path.resolve(__dirname, './wwwroot/demos/webpack/js'),
    entry: {
        app: './app.js'
    },
    resolve: {
        extensions: ['.js']
    },
    output: {
        filename: './wwwroot/demos/webpack/js/bundle.js'
    },
    devtool: 'eval-source-map',

    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: [/node_modules/],
                use: [
                        {
                            loader: "babel-loader",
                            options: { presets: ["es2015"] }
                        }
                ]
            }
        ]
    }
};