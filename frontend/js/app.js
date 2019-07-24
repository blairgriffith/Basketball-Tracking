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
        ApiAction.getRequest("https://localhost:44315/api/conferences", conferences => {
            app.innerHTML = Home(conferences);
    })
    });

    document.querySelector('#app').addEventListener("click", function() {
        if (event.target.classList.contains("select-albumId__select")) {
        const albumId = event.target.parentElement.querySelector(".select-album__id")
            .value;
            console.log(albumId)
        ApiAction.getRequest("https://localhost:44315/api/conferences/"+ conferenceName,
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