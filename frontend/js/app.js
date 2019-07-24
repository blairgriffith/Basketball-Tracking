import Home from "./component/Home";
import Conferences from "./component/Conferences"
import SingleConf from "./component/SingleConf";
import AllTeams from "./component/AllTeams";
import SingleTeam from "./component/SingleTeam";
import Player from "./component/Player";
import ApiAction from "./api/api-actions";

pageBuild();

function pageBuild(){
    home();
    player();
    conferences();
}

function home(){
    const app = document.getElementById('app');
    const home = document.getElementById('nav__Home');
    home.addEventListener('click', function(){
        app.innerHTML = Home();
    })
};

function conferences(){
    const app = document.getElementById('app');
    const conferences= document.getElementById('nav__Conferences');
    conferences.addEventListener('click', function(){
        ApiAction.getRequest("https://localhost:44315/api/conferences", allconf => {
            app.innerHTML = Conferences(allconf);
        })
    })

    document.querySelector('#app').addEventListener("click", function() {
        if (event.target.classList.contains("select-conferenceId__select")) {
        const conferenceId = event.target.parentElement.querySelector(".select-conference__id")
            .value;
        ApiAction.getRequest("https://localhost:44315/api/conferences/"+ conferenceId,
            allconf => {
                document.querySelector('#app').innerHTML = Conferences(allconf);
        },           
        );
    }
  });
};

function player(){
    const app = document.getElementById('app');
    const player = document.getElementById('nav__Player');

}