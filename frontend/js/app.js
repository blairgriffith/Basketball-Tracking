import Home from "./component/Home";
import SingleConf from "./component/SingleConf";
import AllTeams from "./component/AllTeams";
import SingleTeam from "./component/SingleTeam";
import Player from "./component/Player";
import ApiAction from "./api/api-actions";

pageBuild();

function pageBuild(){
    home();
    player();
}

function home(){
    const app = document.getElementById('app');
    const home = document.getElementById('nav__Home');
    home.addEventListener('click', function(){
        ApiAction.getRequest("https://localhost:44315/api/conferences", conferences => {
            app.innerHTML = Home(conferences);
    })
    });

    document.querySelector('#app').addEventListener("click", function() {
        if (event.target.classList.contains("select-conferenceId__select")) {
        const conferenceId = event.target.parentElement.querySelector(".select-conference__id")
            .value;
        ApiAction.getRequest("https://localhost:44315/api/conferences",
            conferences => {
                document.querySelector('#app').innerHTML = Conference(conferences);
        },           
        );
    }
  });
};

function player(){
    const app = document.getElementById('app');
    const player = document.getElementById('nav__Player');

}