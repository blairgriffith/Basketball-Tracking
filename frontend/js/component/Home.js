export default function Home(conferences){
    return `
    <h1>Welcome to Basketball Tracking</h1>
    <h2>Choose a Conference</h2>
    <ul>
        ${conferences.map(conference => {
        return `
            <li>
                <p>${conference.name}</p>
                <img src="${confrence.ImageURL}>
                <input class='select-conference__name' type='hidden' value="${conference.name}">
                <button class='select-conferenceName__select'>Select Conference</button>  
            
            </li>
            `;
        })
        .join("")}
    
    </ul>
        
    `
    };