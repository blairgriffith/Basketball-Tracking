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
    allTeams();
    singleConf();
    singleTeam();
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
        if (event.target.classList.contains("select-conference")) {
        const conferenceId = event.target.parentElement.querySelector(".select-conference__id").value;
        ApiAction.getRequest("https://localhost:44315/api/conferences/"+ conferenceId,
            conf => {
                document.querySelector('#app').innerHTML = SingleConf(conf);
        },           
        );
    }
  });

};

function allTeams(){
    const app = document.getElementById('app');
    const teams= document.getElementById('nav__Teams');
    teams.addEventListener('click', function(){
        ApiAction.getRequest("https://localhost:44315/api/teams", teams => {
            app.innerHTML = AllTeams(teams);
        })
    })

    document.querySelector('#app').addEventListener("click", function() {
        if (event.target.classList.contains("select-teamId__select")) {
        const teamId = event.target.parentElement.querySelector(".select-team__id").value;

        ApiAction.getRequest("https://localhost:44315/api/teams/"+ teamId,
            team => {
                document.querySelector('#app').innerHTML = SingleTeam(team);
            },           
        );
    }
  });
};

function singleTeam(){
    document.querySelector('#app').addEventListener("click", function(){
        if(event.target.classList.contains('add-player_submit')){
            const location = event.target.parentElement.querySelector('.add-player_location').value;
            const playerName = event.target.parentElement.querySelector('.add-player_name').value;
            const playerimage = event.target.parentElement.querySelector('.add-player_imageUrl').value;
            const teamId = event.target.parentElement.querySelector('.add-player_teamId').value;

            const data = {
                playerId: 0,
                location: location,
                Name: playerName,
                imageUrl: playerimage,
                teamId: teamId
            }
            
        ApiAction.postRequest("https://localhost:44315/api/players", data, team => {
            document.querySelector('#app').innerHTML = SingleTeam(team);
        })
        }
    })

    
    document.querySelector('#app').addEventListener("click", function() {
        if (event.target.classList.contains("delete-playerId__delete")) {

            const playerId = event.target.parentElement.querySelector(".delete-player__id").value;
            const teamId = event.target.parentElement.querySelector('.delete-player__teamId')
            
            const data = {
                playerId: playerId,
                teamId: teamId
            }

          ApiAction.deleteRequest("https://localhost:44315/api/players/"+ playerId, data,
            team => {
                document.querySelector('#app').innerHTML = SingleTeam(team);
            },           
            );
        }
    });

    document.querySelector('#app').addEventListener("click", function(){
        if(event.target.classList.contains('edit-player_submit')){

            const playerId = event.target.parentElement.querySelector('.edit-player_playerId').value;            
            const location = event.target.parentElement.querySelector('.edit-player_location').value;
            const playerName = event.target.parentElement.querySelector('.edit-player_name').value;
            const playerimage = event.target.parentElement.querySelector('.edit-player_imageUrl').value;
            const teamId = event.target.parentElement.querySelector('.edit-player_teamId').value;

            const data = {
                playerId: playerId,
                location: location,
                name: playerName,
                imageUrl: playerimage,
                teamId: teamId
            }

            ApiAction.putRequest("https://localhost:44315/api/players/"+ playerId, data, team => {
                document.querySelector('#app').innerHTML = SingleTeam(team);
            })
        }
    })

    
}

function singleConf(){
    document.querySelector('#app').addEventListener("click", function(){
        if(event.target.classList.contains('add-team_submit')){
            const location = event.target.parentElement.querySelector('.add-team_location').value;
            const teamName = event.target.parentElement.querySelector('.add-team_name').value;
            const teamimage = event.target.parentElement.querySelector('.add-team_imageUrl').value;
            const conferenceId = event.target.parentElement.querySelector('.add-team_conferenceId').value;

            const data = {
                teamId: 0,
                location: location,
                Name: teamName,
                imageUrl: teamimage,
                conferenceId: conferenceId
            }
            
        ApiAction.postRequest("https://localhost:44315/api/teams", data, conference => {
            document.querySelector('#app').innerHTML = SingleConf(conference);
        })
        }
    })

    
    document.querySelector('#app').addEventListener("click", function() {
        if (event.target.classList.contains("delete-teamId__delete")) {

            const teamId = event.target.parentElement.querySelector(".delete-team__id").value;
            const conferenceId = event.target.parentElement.querySelector('.delete-team__conferenceId')
            
            const data = {
                teamId: teamId,
                conferenceId: conferenceId
            }

          ApiAction.deleteRequest("https://localhost:44315/api/teams/"+ teamId, data,
            conference => {
                document.querySelector('#app').innerHTML = SingleConf(conference);
            },           
            );
        }
    });

    document.querySelector('#app').addEventListener("click", function(){
        if(event.target.classList.contains('edit-team_submit')){

            const teamId = event.target.parentElement.querySelector('.edit-team_teamId').value;            
            const location = event.target.parentElement.querySelector('.edit-team_location').value;
            const teamName = event.target.parentElement.querySelector('.edit-team_name').value;
            const teamimage = event.target.parentElement.querySelector('.edit-team_imageUrl').value;
            const conferenceId = event.target.parentElement.querySelector('.edit-team_conferenceId').value;

            const data = {
                teamId: teamId,
                location: location,
                name: teamName,
                imageUrl: teamimage,
                conferenceId: conferenceId
            }

            ApiAction.putRequest("https://localhost:44315/api/teams/"+ teamId, data, conference => {
                document.querySelector('#app').innerHTML = SingleConf(conference);
            })
        }
    })

    document.querySelector('#app').addEventListener("click", function() {
        if (event.target.classList.contains("select-playerId__select")) {
        const teamId = event.target.parentElement.querySelector(".select-player__id")
            .value;
        ApiAction.getRequest("https://localhost:44315/api/teams/"+ teamId,
            teams => {
                document.querySelector('#app').innerHTML = SingleTeam(teams);
            },           
        );
    }
  });
}

function player(){
    const app = document.getElementById('app');
    const player = document.getElementById('nav__Player');

}