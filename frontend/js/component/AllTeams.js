export default function AllTeams(teams){
    return `
    
    <h1>Choose a Team</h1>
    <ul>
        ${teams.map(team => {
        return `
            <li>
                <p>${team.name}</p>
                <img class='select-teamId__select' src="${team.imageURL}">
                <input class='select-team__id' type='hidden' value="${team.teamId}">
            
            </li>
            `;
        })
        .join("")}
    
    </ul>
        
    `
    };