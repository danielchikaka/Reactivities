import React, { useState, useEffect, Fragment } from 'react';
import './App.css';
import { Header, Icon, List } from 'semantic-ui-react';
import { IActivity } from '../models/activity';
import axios from 'axios';

const App = () => {
  const [activities, setActivities] = useState<IActivity[]>([]);

  useEffect(() => {
    axios
      .get<IActivity[]>('http://localhost:5000/api/activities')
      .then(response => {
        setActivities(response.data);
      });
  }, []);

  return (
    <Fragment>
      <List>
        {activities.map(activity => (
          <List.Item key={activity.id}>{activity.title}</List.Item>
        ))}
      </List>
    </Fragment>
  );
};

export default App;
