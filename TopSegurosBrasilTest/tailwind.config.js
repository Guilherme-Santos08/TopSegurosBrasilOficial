/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["**/*.cshtml", "**/*.html"],
    theme: {
        extend: {
            colors: {
                'science-blue': {
                    DEFAULT: '#003ED2',
                    50: '#8BADFF',
                    100: '#769FFF',
                    200: '#4D82FF',
                    300: '#2565FF',
                    400: '#004AFB',
                    500: '#003ED2',
                    600: '#002D9A',
                    700: '#001D62',
                    800: '#000C2A',
                    900: '#000000',
                },
            },
        },
    },
    plugins: [],
}
