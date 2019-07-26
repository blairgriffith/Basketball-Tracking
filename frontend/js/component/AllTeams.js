export default function AllTeams(teams){
    return `
    
    <h1>Choose a Team</h1>
    <ul class='main-flex'>
        ${teams.map(team => {
        return `
            <li>
                <img class='select-teamId__select' src="${team.imageURL}">
                <p>${team.location} ${team.name}</p>
                <input class='select-team__id' type='hidden' value="${team.teamId}">
            
            </li>
            `;
        })
        .join("")}
    
    </ul>
        
    `
    };