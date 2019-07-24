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
        const teamId = event.target.parentElement.querySelector(".select-team__id")
            .value;
        ApiAction.getRequest("https://localhost:44315/api/teams/"+ teamId,
            teams => {
                document.querySelector('#app').innerHTML = SingleTeam(teams);
        },           
        );
    }
  });
};

function singleConf(){
        document.querySelector('#app').addEventListener("click", function(){
        if(event.target.classList.contains('add-team_submit')){
            const team = event.target.parentElement.querySelector('.add-team_name').value;
            const teamimage = event.target.parentElement.querySelector('.add-team_imageUrl').value;
            const conferenceId = event.target.parentElement.querySelector('.add-team_conferenceId').value;
            const data = {
                teamId: 0,
                teamName: team,
                imageUrl: teamimage,
                conferenceId: conferenceId
            }
            ApiAction.postRequest("https://localhost:44378/api/teams", data, conference => {
                document.querySelector('#app').innerHTML = SingleConf(conference);
            })
        }
    })

    
      document.querySelector('#app').addEventListener("click", function() {
        if (event.target.classList.contains("delete-teamId__delete")) {
          const team = event.target.parentElement.querySelector(".delete-team__id")
            .value;
          ApiAction.deleteRequest("https://localhost:44378/api/teams/"+ team,team,
            teams => {
                document.querySelector('#app').innerHTML = Teams(teams);
            },           
            );
        }
      });

      document.querySelector('#app').addEventListener("click", function(){
        if(event.target.classList.contains('edit-team_submit')){
            const team = event.target.parentElement.querySelector('.edit-team__teamId').value;
            // const teamimage = event.target.parentElement.querySelector('.edit-team_teamimage').value;
            const name = event.target.parentElement.querySelector('.edit-team_name').value;
            const data = {
                teamId: team,
                teamName: name,
                // ImageUrl: teamimage
            }
            ApiAction.putRequest("https://localhost:44378/api/teams/"+ team, data, teamlist => {
                document.querySelector('#app').innerHTML = Teams(teamlist);
            })
        }
    })
    document.querySelector('#app').addEventListener("click", function() {
        if (event.target.classList.contains("select-teamId__select")) {
        const teamId = event.target.parentElement.querySelector(".select-team__id")
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