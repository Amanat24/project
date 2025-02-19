@keyframes backgroundAnimation {
    0% {background-position: 0% 50%;}
    50% {background-position: 100% 50%;}
    100% {background-position: 0% 50%;}
}

body {
    font-family: 'Poppins', sans-serif;
    margin: 0;
    padding: 0;
    text-align: center;
    overflow-x: hidden;
    background: linear-gradient(270deg, #ffeb3b, #4caf50, #2c6e49);
    background-size: 400% 400%;
    animation: backgroundAnimation 15s ease infinite;
}

header {
    background: rgba(44, 110, 73, 0.9);
    color: white;
    padding: 20px 0;
    text-align: center;
    font-size: 24px;
    position: fixed;
    width: 100%;
    top: 0;
    left: 0;
    z-index: 1000;
    transition: background 0.3s;
}

nav ul {
    list-style: none;
    padding: 0;
}

nav ul li {
    display: inline;
    margin: 0 15px;
}

nav ul li a {
    color: white;
    text-decoration: none;
    font-size: 18px;
    transition: color 0.3s;
}

nav ul li a:hover {
    color: #ffeb3b;
}

.hero {
    position: relative;
    height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;
    background: url('https://source.unsplash.com/1600x900/?agriculture,farm') no-repeat center center/cover;
}

.hero h1 {
    background: rgba(44, 110, 73, 0.7);
    color: white;
    padding: 20px;
    border-radius: 10px;
    font-size: 36px;
}

section {
    padding: 80px 20px;
    margin: 100px auto;
    width: 85%;
    background: white;
    box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.1);
    border-radius: 10px;
    transition: transform 0.3s;
}

section:hover {
    transform: translateY(-5px);
}
