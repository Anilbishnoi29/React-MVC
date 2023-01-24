
 const About = () => {
     const [user, setUser] = React.useState([]);
     const [loading, setLoading] = React.useState(true);
     const [error, setError] = React.useState("");

     React.useEffect(() => {
         const api = async () => {
             try {
                 const userList = await fetch('https://jsonplaceholder.typicode.com/users')
                     .then(response => response.json())
                     .then(data => data)
                 setUser(userList)
                 setLoading(false)
             } catch (e) {
                 setError(e)
             }
         }
         api()
     }, [])

     if (error != "") return <h1>error</h1>

    return (
        <>
            {loading ? "Loading" :
              user.map((itme, index) => (<List key={index} user={itme} />)) 
            }
        </>
    )
}

export default About;

const List = ({ user}) => {
    return (<>
        <div className="row">
            <div className="col-lg-2">{user.id}</div>
            <div className="col-lg-2">{user.name}</div>
            <div className="col-lg-2"><b>{user.username}</b></div>
            <div className="col-lg-2">{user.email}</div>
            <div className="col-lg-2">{user.phone}</div>
        </div>
        <hr />
    </>)
}