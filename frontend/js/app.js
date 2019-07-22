import Home from "./component/Home";
import SingleConf from "./component/SingleConf";
import AllTeams from "./component/AllTeams";
import SingleTeam from "./component/SingleTeam";
import Player from "./component/Player";

pageBuild();

function pageBuild(){
    home();
}

function home(){
    const app = document.getElementById('app');
    const home = document.getElementById('nav__Home');
    home.addEventListener('click', function(){
        app.innerHTML = Home();
    })

    document
};

function player(){
    const app = document.getElementById('app');
    const player = document.getElementById('nav__Player');

}